////import React from 'react';
////import ReactDOM from 'react-dom';
////import { MemoryRouter } from 'react-router-dom';
////import App from './App';

////it('renders without crashing', async () => {
////  const div = document.createElement('div');
////  ReactDOM.render(
////    <MemoryRouter>
////      <App />
////    </MemoryRouter>, div);
////  await new Promise(resolve => setTimeout(resolve, 1000));
////});

import { render, screen } from '@testing-library/react';
import App from './App';

test('renders learn react link', () => {
    render(<App />);
    const linkElement = screen.getByText(/learn react/i);
    expect(linkElement).toBeInTheDocument();
});

